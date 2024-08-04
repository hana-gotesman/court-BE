using Court_BE.Services.LegalCases.models;
using Court_BE.Services.Users.models;
using System;
using System.Collections.Generic;

namespace Court_BE.Services.LegalCases
{
    public class LegalCases
    {
        //private readonly IEntityRepository<Case, int> _caseRepository;
        public List<Case> GetAllCases()
        {
            //TODO - CREATE IIC.Web.EntityFramework.Repositories
            //return _caseRepository.Get().ToList()
            //    .Where(c => !c.CaseId.HasValue);
            User hana = new User(2, "hana");
            User submitsExcitation = new User(1, "אברהם אברהמי");
            User chairmanCommitte = new User(3, "ציון ציוני");
            List<Case> cases = new List<Case>();
            cases.Add(new Case("108/2024", hana, StatusCaseEnum.Active,
                 "בדיקת שמירה החלטה 3", "ערר חרבות ברזל", " 2023 ספטמבר - אוקטובר",
                 DateTime.UtcNow, "15.07.2024", submitsExcitation, chairmanCommitte, "עדיין לא מונה"));
             cases.Add(new Case("107/2024", hana, StatusCaseEnum.Close,
                      "בדיקת שמירה החלטה 2", "ערר חרבות ברזל", "נובמבר - דצמבר 2023",
                      DateTime.UtcNow, "17.07.2024", submitsExcitation, chairmanCommitte, "עדיין לא מונה"));
            return cases;
        }
        public Case GetCaseById(string numCase)
        {
            //TODO - CREATE IIC.Web.EntityFramework.Repositories
            //return _caseRepository.GetByIdAsync(numCase)
            User hana = new User(2, "hana");
            User submitsExcitation = new User(1, "אברהם אברהמי");
            User chairmanCommitte = new User(3, "ציון ציוני");
            List<Case> cases = new List<Case>();
            return new Case("108/2024", hana, StatusCaseEnum.Active,
                 "בדיקת שמירה החלטה 3", "ערר חרבות ברזל", " 2023 ספטמבר - אוקטובר",
                 DateTime.UtcNow, "15.07.2024", submitsExcitation, chairmanCommitte, "עדיין לא מונה");
        }
        public void CreateLegalCase(Case newCase)
        {
            newCase.dateCreate = DateTime.UtcNow;
            newCase.statusId = StatusCaseEnum.Active;
            //TODO create in DB- Add to repo
            //_caseRepository.Add(newCase);
            //await _caseRepository.UnitOfWork.SaveChangesAsync();
            List<User> users = new List<User>();
            users.Add(newCase.user);
            users.Add(newCase.submitsExcitation);
            users.Add(newCase.chairmanCommitte);
            SendMailToUsers(users, newCase.numCase);
        }
        void SendMailToUsers(List<User> users, string numCase)
        {
            foreach (User user in users)
            {
                user.SendMail(numCase);
            }
        }
    }
}
