using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisBluelinePart : IScriptable
	{
		private CBool _passed;
		private TweakDBID _captionIconRecordId;

		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get
			{
				if (_passed == null)
				{
					_passed = (CBool) CR2WTypeManager.Create("Bool", "passed", cr2w, this);
				}
				return _passed;
			}
			set
			{
				if (_passed == value)
				{
					return;
				}
				_passed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("captionIconRecordId")] 
		public TweakDBID CaptionIconRecordId
		{
			get
			{
				if (_captionIconRecordId == null)
				{
					_captionIconRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "captionIconRecordId", cr2w, this);
				}
				return _captionIconRecordId;
			}
			set
			{
				if (_captionIconRecordId == value)
				{
					return;
				}
				_captionIconRecordId = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
