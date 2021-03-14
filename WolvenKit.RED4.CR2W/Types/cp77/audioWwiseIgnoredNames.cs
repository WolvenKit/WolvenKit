using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWwiseIgnoredNames : audioAudioMetadata
	{
		private CArray<CName> _ignoredNames;

		[Ordinal(1)] 
		[RED("ignoredNames")] 
		public CArray<CName> IgnoredNames
		{
			get
			{
				if (_ignoredNames == null)
				{
					_ignoredNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "ignoredNames", cr2w, this);
				}
				return _ignoredNames;
			}
			set
			{
				if (_ignoredNames == value)
				{
					return;
				}
				_ignoredNames = value;
				PropertySet(this);
			}
		}

		public audioWwiseIgnoredNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
