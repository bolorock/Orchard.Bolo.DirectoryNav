using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Bolo.DirectoryNav.Models;
using Orchard.Data;

namespace Bolo.DirectoryNav.Services
{
    public class DirectoryNavService : IDirectoryNavService
    {

        private readonly IRepository<TitleRecord> _titleRepository;
        private readonly IRepository<LinkRecord> _linkRepository;

        public DirectoryNavService(IRepository<TitleRecord> titleRepository, IRepository<LinkRecord> linkRepository)
        {
            _titleRepository = titleRepository;
            _linkRepository = linkRepository;
        }

        public IEnumerable<TitleRecord> GetTitles()
        {
            return _titleRepository.Table;
        }


        public IEnumerable<Headline> GetHeadlines()
        {
            IQueryable<TitleRecord> titles = _titleRepository.Table;
            if (titles == null) return null;
            var query = titles.Select(o => new Headline
             {
                 TitleId = o.Id,
                 Name = o.Name,
                 linkNum=o.LinkRecords.Count()
             });
            return query;
        }

        public IEnumerable<string> AllowedFileFormats
        {
            get { throw new NotImplementedException(); }
        }

        public Models.Headline GetHeadline(int titleId)
        {
            var titleRecord = _titleRepository.Get(o => o.Id == titleId);
            return new Headline
            {
                links = titleRecord.LinkRecords == null ? null : titleRecord.LinkRecords.Select(o => new LinkRecord
                {
                    Id = o.Id,
                    Name = o.Name,
                    Url = o.Url,
                    IsShow = o.IsShow
                }),
                Name = titleRecord.Name,
                TitleId = titleRecord.Id
            };
        }

        public void CreateTitle(string titleName)
        {
            TitleRecord record = new TitleRecord
            {
                Name = titleName
            };
            _titleRepository.Create(record);
        }

        public void DeleteTitle(int titleId)
        {
            var entity = _titleRepository.Get(o => o.Id == titleId);
            if (entity != null)
            {
                _titleRepository.Delete(entity);
            }
        }

        public void EditTitle(TitleRecord record)
        {
            _titleRepository.Update(record);
        }

        public LinkRecord GetLink(int linkId)
        {
            return _linkRepository.Get(o => o.Id == linkId);
        }

        public void AddLink(int titleId, string linkName, string url)
        {
            var titleRecord = _titleRepository.Get(o => o.Id == titleId);
            LinkRecord record = new LinkRecord
            {
                Name = linkName,
                Url = url
            };
            titleRecord.LinkRecords.Add(record);
            _linkRepository.Create(record);
            _titleRepository.Update(titleRecord);
        }

        public void EditLink(LinkRecord record)
        {
            _linkRepository.Update(record);
        }

        public void DeleteLink(int linkId)
        {
            var linkRecord = _linkRepository.Get(o => o.Id == linkId);
            if (linkRecord != null)
            {
                _linkRepository.Delete(linkRecord);
            }
        }

        public void ReorderLinks(string titleName, IEnumerable<string> links)
        {
            throw new NotImplementedException();
        }
    }
}