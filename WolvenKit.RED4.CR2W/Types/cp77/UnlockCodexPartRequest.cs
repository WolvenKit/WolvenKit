using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnlockCodexPartRequest : gameScriptableSystemRequest
	{
		private TweakDBID _codexRecordID;
		private CName _partName;

		[Ordinal(0)] 
		[RED("codexRecordID")] 
		public TweakDBID CodexRecordID
		{
			get
			{
				if (_codexRecordID == null)
				{
					_codexRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "codexRecordID", cr2w, this);
				}
				return _codexRecordID;
			}
			set
			{
				if (_codexRecordID == value)
				{
					return;
				}
				_codexRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		public UnlockCodexPartRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
