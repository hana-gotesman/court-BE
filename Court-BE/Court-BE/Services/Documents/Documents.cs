using Court_BE.Services.LegalCases.models;
using Court_BE.Services.Users.models;
using System;
using System.Collections.Generic;

namespace Court_BE.Services.Documents
{
    public class Documents
    {
        //private readonly IEntityRepository<Document, int> _docRepository;

        public void CreateDocumentByCaseId(List<Documents> docs,int caseId)
        {

            //TODO create in DB- Add to repo
            //_docRepository.Add(docs);
            //await _docRepository.UnitOfWork.SaveChangesAsync();

        }


    }
}
