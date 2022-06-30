using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Arbelos
{
    public interface IInteractable 
    {
        protected AnimationOverrideController animationOverrideController;
        protected UnityEvent OnInteractEnterEvent;
        protected UnityEvent OnInteractExitEvent;
        protected UnityEvent OnInteractUpdateEvent;


        public virtual Interact() { }

        protected void OnInteractEnter() 
        { 
            if(OnInteractEnterEvent != null)
            {
                OnInteractEnterEvent.Invoke();
            }
        }
        protected void OnInteractExit() 
        {
            if (OnInteractExitEvent != null)
            {
                OnInteractExitEvent.Invoke();
            }
        }
        protected void OnInteractUpdate() 
        {
            if (OnInteracterUpdateEvent != null)
            {
                OnInteracterUpdateEvent.Invoke();
            }
        }
    }
}
