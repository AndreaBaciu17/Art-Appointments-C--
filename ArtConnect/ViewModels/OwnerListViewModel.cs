//added 11.21.24: View Models for front/back end and Razor views
using ArtConnect.Models;

namespace ArtConnect.ViewModels
{
    public class OwnerListViewModel
    {
        public IEnumerable<Owner>? Owners { get; set; }
    }
}