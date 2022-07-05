using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arbelos
{
    public interface IInteractableNetworked : IInteractable
    {
        public virtual void RPC_Interact();
    }
}
