using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWrappedEntIDArray : CVariable
	{
		private CArray<entEntityID> _arr;

		[Ordinal(0)] 
		[RED("arr")] 
		public CArray<entEntityID> Arr
		{
			get => GetProperty(ref _arr);
			set => SetProperty(ref _arr, value);
		}

		public gameWrappedEntIDArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
