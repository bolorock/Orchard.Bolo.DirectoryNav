﻿using System;
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


        public IEnumerable<Headline> GetHeadlines()
        {
            IQueryable<TitleRecord> titles = _titleRepository.Table;
            if (titles == null) return null;
            var query = titles.Select(o => new Headline
             {
                 TitleId = o.Id,
                 Name = o.Name
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
                links = titleRecord.LinkRecords == null ? null : titleRecord.LinkRecords.Select(o => new Link
                {
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

        public void DeleteTitle(string titleName)
        {
            throw new NotImplementedException();
        }

        public void RenameTitle(string titleName, string newName)
        {
            throw new NotImplementedException();
        }

        public Models.Link GetLink(string titleName, string linkName)
        {
            throw new NotImplementedException();
        }

        public void AddLInk(int titleId, string linkName, string url)
        {
            LinkRecord record = new LinkRecord
            {
                Name = linkName,
                Url = url
            };
            _linkRepository.Create(record);
        }

        public void DeleteLink(string titleName, string linkName)
        {
            throw new NotImplementedException();
        }

        public void ReorderLinks(string titleName, IEnumerable<string> links)
        {
            throw new NotImplementedException();
        }
    }
}