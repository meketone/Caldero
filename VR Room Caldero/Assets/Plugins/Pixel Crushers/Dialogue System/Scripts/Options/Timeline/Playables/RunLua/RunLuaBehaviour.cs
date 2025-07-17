// Recompile at 16/07/2025 12:23:10 p. m.
#if USE_TIMELINE
#if UNITY_2017_1_OR_NEWER
// Copyright (c) Pixel Crushers. All rights reserved.

using UnityEngine;
using UnityEngine.Playables;
using System;

namespace PixelCrushers.DialogueSystem
{

    [Serializable]
    public class RunLuaBehaviour : PlayableBehaviour
    {

        [Tooltip("Run this Lua code.")]
        [TextArea(5, 5)]
        public string luaCode;

    }
}
#endif
#endif
