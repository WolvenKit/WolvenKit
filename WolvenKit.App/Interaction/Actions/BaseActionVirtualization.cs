using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.Virtualization.Actions
{
    /// <summary>
    ///     Base Class that does an action on the dispatcher thread. Simply implement the DoAction method.
    /// </summary>
    public abstract class BaseActionVirtualization : IVirtualizationAction
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseActionVirtualization" /> class.
        /// </summary>
        /// <param name="threadModel">The thread model.</param>
        public BaseActionVirtualization(VirtualActionThreadModelEnum threadModel)
        {
            this.ThreadModel = threadModel;
        }

        public abstract void DoAction();

        /// <summary>
        ///     Gets or sets the thread model.
        /// </summary>
        /// <value>
        ///     The thread model.
        /// </value>
        public VirtualActionThreadModelEnum ThreadModel { get; set; }
    }
}