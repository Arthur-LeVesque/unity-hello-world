//*****************************************************************************
// Author: Arthur LeVesque
// Copyright: Salty Snail Studios, 2024
//*****************************************************************************

namespace SaltySnailStudios.HelloWorld
{
    using Unity.VisualScripting;
    using UnityEngine;

    /// <summary>
    /// [INSERT CLASS COMMENT HERE]
    /// </summary>
    [UnitCategory("OnChain Studios")]
    public class HelloWorldUnit : Unit
    {
        /// <summary>
        /// The ControlInput port variable
        /// </summary>
        [DoNotSerialize]
        public ControlInput InputTrigger;

        /// <summary>
        /// The ControlOutput port variable
        /// </summary>
        [DoNotSerialize]
        public ControlOutput OutputTrigger;

        /// <summary>
        /// The message prefix for the output.
        /// </summary>
        public ValueInput MessagePrefix;
        
        /// <summary>
        /// The the message to output.
        /// </summary>
        [DoNotSerialize]
        public ValueInput Message;

        /// <inheritdoc/>
        protected override void Definition()
        {
            InputTrigger = ControlInput(nameof(InputTrigger), Execute);

            OutputTrigger = ControlOutput(nameof(OutputTrigger));
            
            MessagePrefix = ValueInput(nameof(MessagePrefix), "Hello World: ");

            Message = ValueInput(nameof(Message), string.Empty);

            Succession(InputTrigger, OutputTrigger);
        }

        /// <summary>
        /// Execution method for the node when <see cref="InputTrigger"/> is invoked.
        /// </summary>
        /// <param name="flow">The current graph flow.</param>
        /// <returns>Always <see cref="OutputTrigger"/>.</returns>
        protected ControlOutput Execute(Flow flow)
        {
            var messagePrefix = flow.GetValue<string>(MessagePrefix);
            var message = flow.GetValue<string>(Message);
            Debug.Log($"{messagePrefix}{message}");
            return OutputTrigger;
        }
    }
}