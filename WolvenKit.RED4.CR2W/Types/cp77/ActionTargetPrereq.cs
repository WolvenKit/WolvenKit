using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionTargetPrereq : gameIScriptablePrereq
	{
		private wCHandle<gamedataAIActionTarget_Record> _targetRecord;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("targetRecord")] 
		public wCHandle<gamedataAIActionTarget_Record> TargetRecord
		{
			get
			{
				if (_targetRecord == null)
				{
					_targetRecord = (wCHandle<gamedataAIActionTarget_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionTarget_Record", "targetRecord", cr2w, this);
				}
				return _targetRecord;
			}
			set
			{
				if (_targetRecord == value)
				{
					return;
				}
				_targetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public ActionTargetPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
