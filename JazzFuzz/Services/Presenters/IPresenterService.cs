using System.Collections.Generic;

namespace JazzFuzz.Services.Presenters
{
    public interface IPresenterService
    {
        void Present(IEnumerable<string> values);
    }
}