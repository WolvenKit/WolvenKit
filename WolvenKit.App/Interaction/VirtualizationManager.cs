using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaChiTech.Virtualization.Actions;
using AlphaChiTech.VirtualizingCollection.Interfaces;

namespace AlphaChiTech.VirtualizingCollection
{
    public class VirtualizationManager
    {
        private readonly object _actionLock = new object();

        private readonly List<IVirtualizationAction> _actions = new List<IVirtualizationAction>();

        private bool _processing;

        private Action<Action> _uiThreadExecuteAction;

        public static VirtualizationManager Instance { get; } = new VirtualizationManager();

        public static bool IsInitialized { get; private set; }

        public Action<Action> UIThreadExecuteAction
        {
            get => this._uiThreadExecuteAction;
            set
            {
                this._uiThreadExecuteAction = value;
                IsInitialized = true;
            }
        }

        public void AddAction(IVirtualizationAction action)
        {
            lock (this._actionLock)
            {
                this._actions.Add(action);
            }
        }

        public void AddAction(Action action)
        {
            this.AddAction(new ActionVirtualizationWrapper(action));
        }

        public void ProcessActions()
        {
            if (this._processing)
                return;

            this._processing = true;

            List<IVirtualizationAction> lst;
            lock (this._actionLock)
            {
                lst = this._actions.ToList();
            }

            foreach (var action in lst)
            {
                var bdo = true;

                if (action is IRepeatingVirtualizationAction)
                {
                    bdo = (action as IRepeatingVirtualizationAction).IsDueToRun();
                }

                if (!bdo)
                    continue;
                switch (action.ThreadModel)
                {
                    case VirtualActionThreadModelEnum.UseUIThread:
                        if (this.UIThreadExecuteAction == null) // PLV
                            throw new Exception(
                                "VirtualizationManager isn’t already initialized !  set the VirtualizationManager’s UIThreadExcecuteAction (VirtualizationManager.Instance.UIThreadExcecuteAction = a => Dispatcher.Invoke( a );)");
                        this.UIThreadExecuteAction.Invoke(() => action.DoAction());
                        break;
                    case VirtualActionThreadModelEnum.Background:
                        Task.Run(() => action.DoAction()).ConfigureAwait(false);
                        break;
                    default:
                        break;
                }

                if (action is IRepeatingVirtualizationAction)
                {
                    if ((action as IRepeatingVirtualizationAction).KeepInActionsList())
                        continue;
                    lock (this._actionLock)
                    {
                        this._actions.Remove(action);
                    }
                }
                else
                {
                    lock (this._actionLock)
                    {
                        this._actions.Remove(action);
                    }
                }
            }

            this._processing = false;
        }

        public void RunOnUi(IVirtualizationAction action)
        {
            if (this.UIThreadExecuteAction == null) // PLV
                throw new Exception(
                    "VirtualizationManager isn’t already initialized !  set the VirtualizationManager’s UIThreadExcecuteAction (VirtualizationManager.Instance.UIThreadExcecuteAction = a => Dispatcher.Invoke( a );)");
            this.UIThreadExecuteAction.Invoke(action.DoAction);
        }

        public void RunOnUi(Action action)
        {
            this.RunOnUi(new ActionVirtualizationWrapper(action));
        }
    }
}
