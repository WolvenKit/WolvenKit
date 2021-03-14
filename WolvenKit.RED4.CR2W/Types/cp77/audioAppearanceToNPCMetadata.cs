using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAppearanceToNPCMetadata : CVariable
	{
		private CArray<CName> _appearances;
		private CName _foleyNPCMetadata;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CName>) CR2WTypeManager.Create("array:CName", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("foleyNPCMetadata")] 
		public CName FoleyNPCMetadata
		{
			get
			{
				if (_foleyNPCMetadata == null)
				{
					_foleyNPCMetadata = (CName) CR2WTypeManager.Create("CName", "foleyNPCMetadata", cr2w, this);
				}
				return _foleyNPCMetadata;
			}
			set
			{
				if (_foleyNPCMetadata == value)
				{
					return;
				}
				_foleyNPCMetadata = value;
				PropertySet(this);
			}
		}

		public audioAppearanceToNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
