using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.Interfaces
{
    public interface IMobileServicePlatform
    {
        Task<MobileServiceUser> LoginAsync(MobileServiceAuthenticationProvider provider);
    }
}
