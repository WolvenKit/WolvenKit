using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectOnOwner : StatusEffectTasks
	{
		private TweakDBID _statusEffectID;

		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get
			{
				if (_statusEffectID == null)
				{
					_statusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectID", cr2w, this);
				}
				return _statusEffectID;
			}
			set
			{
				if (_statusEffectID == value)
				{
					return;
				}
				_statusEffectID = value;
				PropertySet(this);
			}
		}

		public RemoveStatusEffectOnOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
