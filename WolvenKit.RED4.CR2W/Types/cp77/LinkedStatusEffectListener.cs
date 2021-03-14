using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffectListener : gameScriptStatusEffectListener
	{
		private wCHandle<gameObject> _instigatorObject;
		private TweakDBID _linkedEffect;
		private CHandle<RemoveLinkedStatusEffectsEvent> _evt;
		private CHandle<gameStatusEffect> _statusEffect;

		[Ordinal(0)] 
		[RED("instigatorObject")] 
		public wCHandle<gameObject> InstigatorObject
		{
			get
			{
				if (_instigatorObject == null)
				{
					_instigatorObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigatorObject", cr2w, this);
				}
				return _instigatorObject;
			}
			set
			{
				if (_instigatorObject == value)
				{
					return;
				}
				_instigatorObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("linkedEffect")] 
		public TweakDBID LinkedEffect
		{
			get
			{
				if (_linkedEffect == null)
				{
					_linkedEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "linkedEffect", cr2w, this);
				}
				return _linkedEffect;
			}
			set
			{
				if (_linkedEffect == value)
				{
					return;
				}
				_linkedEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("evt")] 
		public CHandle<RemoveLinkedStatusEffectsEvent> Evt
		{
			get
			{
				if (_evt == null)
				{
					_evt = (CHandle<RemoveLinkedStatusEffectsEvent>) CR2WTypeManager.Create("handle:RemoveLinkedStatusEffectsEvent", "evt", cr2w, this);
				}
				return _evt;
			}
			set
			{
				if (_evt == value)
				{
					return;
				}
				_evt = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statusEffect")] 
		public CHandle<gameStatusEffect> StatusEffect
		{
			get
			{
				if (_statusEffect == null)
				{
					_statusEffect = (CHandle<gameStatusEffect>) CR2WTypeManager.Create("handle:gameStatusEffect", "statusEffect", cr2w, this);
				}
				return _statusEffect;
			}
			set
			{
				if (_statusEffect == value)
				{
					return;
				}
				_statusEffect = value;
				PropertySet(this);
			}
		}

		public LinkedStatusEffectListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
