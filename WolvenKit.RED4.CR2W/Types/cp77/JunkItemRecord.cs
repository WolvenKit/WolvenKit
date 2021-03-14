using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JunkItemRecord : CVariable
	{
		private TweakDBID _junkItemID;

		[Ordinal(0)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get
			{
				if (_junkItemID == null)
				{
					_junkItemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "junkItemID", cr2w, this);
				}
				return _junkItemID;
			}
			set
			{
				if (_junkItemID == value)
				{
					return;
				}
				_junkItemID = value;
				PropertySet(this);
			}
		}

		public JunkItemRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
