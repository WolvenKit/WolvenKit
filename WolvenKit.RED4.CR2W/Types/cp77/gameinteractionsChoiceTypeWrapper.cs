using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceTypeWrapper : CVariable
	{
		private CUInt32 _properties;

		[Ordinal(0)] 
		[RED("properties")] 
		public CUInt32 Properties
		{
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}

		public gameinteractionsChoiceTypeWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
