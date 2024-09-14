//*****************************************************************************
// Author: Arthur LeVesque
// Copyright: Salty Snail Studios, 2024
//*****************************************************************************

namespace SaltySnailStudios.HelloWorld
{
    using UnityEngine;

    /// <summary>
    /// A Hello World Example for a monobehaviour.
    /// </summary>
    public class HelloWorldBehaviour : MonoBehaviour
    {
        /// <summary>
        /// The debug log prefix editable on the game object.
        /// </summary>
        [SerializeField]
        protected string DebugLogPrefix = "Hello World: ";

        /// <summary>
        /// Unity Start Lifecycle Method.
        /// </summary>
        void Start()
        {
            CustomDebugLog(nameof(Start));
        }

        /// <summary>
        /// Unity OnEnable Lifecycle Method.
        /// </summary>
        void OnEnable()
        {
            CustomDebugLog(nameof(OnEnable));
        }

        /// <summary>
        /// Unity OnDisable Lifecycle Method.
        /// </summary>
        void OnDisable()
        {
            CustomDebugLog(nameof(OnDisable));
        }

        /// <summary>
        /// Prints out a message with the <see cref="DebugLogPrefix"/> prepended to the <see cref="message"/>
        /// </summary>
        /// <param name="message">The message to output.</param>
        protected void CustomDebugLog(string message)
        {
            Debug.Log($"{DebugLogPrefix}{message}");
        }
    }
}