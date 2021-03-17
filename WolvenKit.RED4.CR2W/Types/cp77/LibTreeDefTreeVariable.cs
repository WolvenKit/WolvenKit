using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariable : ISerializable
	{
		private CUInt16 _id;
		private CName _readableName;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("readableName")] 
		public CName ReadableName
		{
			get => GetProperty(ref _readableName);
			set => SetProperty(ref _readableName, value);
		}

		public LibTreeDefTreeVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
