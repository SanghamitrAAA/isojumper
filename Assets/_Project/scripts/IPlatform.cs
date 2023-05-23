using UnityEngine;

public interface IPlatform
{
    bool Flipped { get; }
    void SetFlippedState(bool flipped);
    void SetPlatformColor(Color color);
}
