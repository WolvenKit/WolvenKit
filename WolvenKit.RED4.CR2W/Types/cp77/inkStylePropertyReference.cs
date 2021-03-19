using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStylePropertyReference : CVariable
	{
		private CName _referencedPath;

		[Ordinal(0)] 
		[RED("referencedPath")] 
		public CName ReferencedPath
		{
			get => GetProperty(ref _referencedPath);
			set => SetProperty(ref _referencedPath, value);
		}

		public inkStylePropertyReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
