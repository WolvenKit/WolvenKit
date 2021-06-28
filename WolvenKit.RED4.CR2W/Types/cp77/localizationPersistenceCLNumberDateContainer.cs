using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceCLNumberDateContainer : ISerializable
	{
		private CName _clNumber;
		private CName _clTimestamp;

		[Ordinal(0)] 
		[RED("clNumber")] 
		public CName ClNumber
		{
			get => GetProperty(ref _clNumber);
			set => SetProperty(ref _clNumber, value);
		}

		[Ordinal(1)] 
		[RED("clTimestamp")] 
		public CName ClTimestamp
		{
			get => GetProperty(ref _clTimestamp);
			set => SetProperty(ref _clTimestamp, value);
		}

		public localizationPersistenceCLNumberDateContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
