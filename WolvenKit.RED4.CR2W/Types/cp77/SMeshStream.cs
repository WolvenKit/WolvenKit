using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshStream : CVariable
	{
		private serializationDeferredDataBuffer _data;
		private CEnum<EMeshStreamType> _type;

		[Ordinal(0)] 
		[RED("data")] 
		public serializationDeferredDataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<EMeshStreamType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public SMeshStream(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
