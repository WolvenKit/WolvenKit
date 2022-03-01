using System;

namespace AlphaChiTech.Virtualization.Actions
{
    /// <summary>
    ///     This is a VirtualAction that wraps an Action, optionally with a repeating schedule.
    /// </summary>
    public class ActionVirtualizationWrapper : BaseRepeatableActionVirtualization
    {
        private readonly Action _action;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ActionVirtualizationWrapper" /> class.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="threadModel">The thread model.</param>
        /// <param name="isRepeating">if set to <c>true</c> [is repeating].</param>
        /// <param name="repeatingSchedule">The repeating schedule.</param>
        public ActionVirtualizationWrapper(Action action,
            VirtualActionThreadModelEnum threadModel = VirtualActionThreadModelEnum.UseUIThread,
            bool isRepeating = false, TimeSpan? repeatingSchedule = null)
            : base(threadModel, isRepeating, repeatingSchedule)
        {
            this._action = action;
        }

        /// <summary>
        ///     Does the action.
        /// </summary>
        public override void DoAction()
        {
            var a = this._action;
            this.LastRun = DateTime.Now;

            if (a != null)
            {
                a.Invoke();
            }
        }
    }
}