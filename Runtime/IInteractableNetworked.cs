using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arbelos
{
    public interface IInteractableNetworked : IInteractable
    {
        public virtual rpc_interact()
        {
            Debug.Log("Interacting over the network....");
        }

    }
}
