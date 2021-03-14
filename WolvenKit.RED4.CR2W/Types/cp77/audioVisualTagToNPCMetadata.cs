using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagToNPCMetadata : CVariable
	{
		private CArray<CName> _visualTags;
		private CName _foleyNPCMetadata;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get
			{
				if (_visualTags == null)
				{
					_visualTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "visualTags", cr2w, this);
				}
				return _visualTags;
			}
			set
			{
				if (_visualTags == value)
				{
					return;
				}
				_visualTags = value;
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

		public audioVisualTagToNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
