using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingNodeMeshResourceFilter : CVariable
	{
		private CArray<raRef<CMesh>> _forceFilterIgnore;
		private CArray<raRef<CMesh>> _forceFilterMatch;

		[Ordinal(0)] 
		[RED("forceFilterIgnore")] 
		public CArray<raRef<CMesh>> ForceFilterIgnore
		{
			get
			{
				if (_forceFilterIgnore == null)
				{
					_forceFilterIgnore = (CArray<raRef<CMesh>>) CR2WTypeManager.Create("array:raRef:CMesh", "forceFilterIgnore", cr2w, this);
				}
				return _forceFilterIgnore;
			}
			set
			{
				if (_forceFilterIgnore == value)
				{
					return;
				}
				_forceFilterIgnore = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceFilterMatch")] 
		public CArray<raRef<CMesh>> ForceFilterMatch
		{
			get
			{
				if (_forceFilterMatch == null)
				{
					_forceFilterMatch = (CArray<raRef<CMesh>>) CR2WTypeManager.Create("array:raRef:CMesh", "forceFilterMatch", cr2w, this);
				}
				return _forceFilterMatch;
			}
			set
			{
				if (_forceFilterMatch == value)
				{
					return;
				}
				_forceFilterMatch = value;
				PropertySet(this);
			}
		}

		public worldSceneRecordingNodeMeshResourceFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
