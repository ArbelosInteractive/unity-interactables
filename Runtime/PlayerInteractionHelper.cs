using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

namespace Stemuli
{
    public class PlayerInteractionHelper : NetworkBehaviour
    {
        public List<AnimatorOverrideController> animatorOverrideControllers = new List<AnimatorOverrideController>();

        private RuntimeAnimatorController defaultController;
        private Animator animator;

        public override void Spawned()
        {
            animator = GetComponent<NetworkMecanimAnimator>().Animator;
            defaultController = animator.runtimeAnimatorController;
        }

        [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
        public void RPC_ChangeAnimatorController(int animatorIndex, RpcInfo info = default)
        {
            //Create a way to find the player using playerRef from fusion
            var interactionHelper = PlayerManager.Get(info.Source).GetComponent<PlayerInteractionHelper>();

            interactionHelper.animator.runtimeAnimatorController = animatorOverrideControllers[animatorIndex];
        }

        [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
        public void RPC_SetDefaultAnimatorController(RpcInfo info = default)
        {
            var interactionHelper = PlayerManager.Get(info.Source).GetComponent<PlayerInteractionHelper>();
            interactionHelper.animator.runtimeAnimatorController = defaultController;
        }
    }
}
