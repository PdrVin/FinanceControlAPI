using Application.Interfaces;
using Domain.Entities;
using Infra.Context;
using Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class IncomeRepository(FinanceDbContext context)
    : Repository<Income>(context), IIncomeRepository
{ }