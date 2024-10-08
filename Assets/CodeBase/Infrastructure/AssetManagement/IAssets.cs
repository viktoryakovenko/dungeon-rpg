using System.Threading.Tasks;
using CodeBase.Infrastructure.Services;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace CodeBase.Infrastructure.AssetManagement
{
    public interface IAssets : IService
    {
        Task<GameObject> Instantiate(string address);
        Task<GameObject> Instantiate(string address, Vector3 at);
        Task<GameObject> Instantiate(string address, Transform parent);
        Task<T> Load<T>(AssetReference assetReference) where T : class;
        void CleanUp();
        Task<T> Load<T>(string adress) where T : class;
        void Initialize();
    }
}