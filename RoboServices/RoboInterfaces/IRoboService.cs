using RoboModels.RoboModels;

namespace RoboServices.RoboInterfaces
{
    public interface IRoboService<T>
    {
        RoboApiModel GetApiRobo(string servicoApiRobo);

        RoboApiModel PutApiRobo(string servicoApiRobo, T put);
    }
}
