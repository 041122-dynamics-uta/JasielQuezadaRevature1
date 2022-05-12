using SalesModels;
using SalesRepository;

namespace SalesBusiness;
public class SalesBusinessClass
{
    //inject the dependency into the class
    private SalesRepoClass _repo { get; set; }
    public SalesBusinessClass(SalesRepoClass r)
    {
        this._repo = r;
    }

    public List<Member> MembersList()
    {
        List<Member> ml = _repo.MembersList();



        return ml;
    }
}
