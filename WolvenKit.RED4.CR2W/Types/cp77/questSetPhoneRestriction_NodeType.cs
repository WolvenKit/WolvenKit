using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneRestriction_NodeType : questIPhoneManagerNodeType
	{
		private CBool _applyPhoneRestriction;

		[Ordinal(0)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get => GetProperty(ref _applyPhoneRestriction);
			set => SetProperty(ref _applyPhoneRestriction, value);
		}

		public questSetPhoneRestriction_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
