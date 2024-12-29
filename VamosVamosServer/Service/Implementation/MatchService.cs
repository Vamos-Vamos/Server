using Microsoft.AspNetCore.Mvc;
using VamosVamosServer.DAO.Interfaces;
using VamosVamosServer.Model.MatchModel;
using VamosVamosServer.Service.Interfaces;

namespace VamosVamosServer.Service.Implementation;

public class MatchService : IMatchService
{
    private IMatchDAO dao;

    public MatchService(IMatchDAO dao)
    {
        this.dao = dao;
    }

    public ActionResult UpdateMatchScore(string token, long matchId, long scoreTeam1, long scoreTeam2)
    {
        return dao.UpdateMatchScore(token, matchId, scoreTeam1, scoreTeam2);
    }

    public ActionResult<Match?> GetMatch(string token, long matchId)
    {
        return dao.GetMatch(token, matchId);
    }

    public ActionResult<List<Match>> GetAllMatches(string token, long page, long limit)
    {
        return dao.GetAllMatches(token, page, limit);
    }
}