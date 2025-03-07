﻿using FluentResults;
using ItineraryManager.Domain.Paginations;

namespace ItineraryManager.Domain.Itineraries.Dependencies;

public interface IItineraryRepository
{
    public Task<Result> Save(CancellationToken cancellationToken);
    
    public Result Add(Itinerary itinerary);
    
    public Task<Result<Paginated<Itinerary>>> Get(PaginationRequest pagination, CancellationToken cancellationToken);
    
    public Task<Result<Itinerary>> Get(Guid itineraryId, CancellationToken cancellationToken);

    public Task<Result> Delete(Guid itineraryId, CancellationToken cancellationToken);
}