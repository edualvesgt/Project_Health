﻿using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IEspecializadadeRepository
    {
        List<Especialidade> List();

        Especialidade SearchById(Guid id);

        void Create(Especialidade especialidade);

        void Update(Guid id, Especialidade especialidade);

        void Delete(Guid Id);
    }
}
