using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodInsuraneClassLibrary
{
    class DevTeamRepo
    {
        public static void Create(DevTeam devTeam)
        {

        }

        public static DevTeam Read(int teamId)
        {
            return null;
        }

        public static void Update(DevTeam devTeam)
        {

        }

        public static void Delete(int teamId)
        {

        }
        public void AddMember(Developer developer)
        {
            if (developer != null)
            {
                Members.Add(developer);
            }

        }

        public void RemoveMember(int developerId)
        {
            Developer dev = Members.Find(Dev => Dev.Id.Equals(developerId));
            if (dev != null)
            {
                Members.Remove(dev);
            }
        }

        public void AddMembers(List<Developer> developers)
        {
            if (developers.Count > 0)
            {
                Members.AddRange(developers);
            }
        }

        public void RemoveMembers(List<int> Ids)
        {
            foreach (int id in Ids)
            {
                RemoveMember(id);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is DevTeam team &&
                   Id == team.Id &&
                   Name == team.Name &&
                   EqualityComparer<List<Developer>>.Default.Equals(Members, team.Members);
        }
    }
}
