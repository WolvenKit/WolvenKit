using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConsumableUseEvents : ConsumableTransitions
	{
		private CBool _effectsApplied;
		private CBool _modelRemoved;
		private gameItemID _activeConsumable;

		[Ordinal(0)] 
		[RED("effectsApplied")] 
		public CBool EffectsApplied
		{
			get
			{
				if (_effectsApplied == null)
				{
					_effectsApplied = (CBool) CR2WTypeManager.Create("Bool", "effectsApplied", cr2w, this);
				}
				return _effectsApplied;
			}
			set
			{
				if (_effectsApplied == value)
				{
					return;
				}
				_effectsApplied = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("modelRemoved")] 
		public CBool ModelRemoved
		{
			get
			{
				if (_modelRemoved == null)
				{
					_modelRemoved = (CBool) CR2WTypeManager.Create("Bool", "modelRemoved", cr2w, this);
				}
				return _modelRemoved;
			}
			set
			{
				if (_modelRemoved == value)
				{
					return;
				}
				_modelRemoved = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activeConsumable")] 
		public gameItemID ActiveConsumable
		{
			get
			{
				if (_activeConsumable == null)
				{
					_activeConsumable = (gameItemID) CR2WTypeManager.Create("gameItemID", "activeConsumable", cr2w, this);
				}
				return _activeConsumable;
			}
			set
			{
				if (_activeConsumable == value)
				{
					return;
				}
				_activeConsumable = value;
				PropertySet(this);
			}
		}

		public ConsumableUseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
