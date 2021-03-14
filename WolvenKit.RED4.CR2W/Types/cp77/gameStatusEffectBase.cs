using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectBase : IScriptable
	{
		private TweakDBID _statusEffectRecordID;

		[Ordinal(0)] 
		[RED("statusEffectRecordID")] 
		public TweakDBID StatusEffectRecordID
		{
			get
			{
				if (_statusEffectRecordID == null)
				{
					_statusEffectRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectRecordID", cr2w, this);
				}
				return _statusEffectRecordID;
			}
			set
			{
				if (_statusEffectRecordID == value)
				{
					return;
				}
				_statusEffectRecordID = value;
				PropertySet(this);
			}
		}

		public gameStatusEffectBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
