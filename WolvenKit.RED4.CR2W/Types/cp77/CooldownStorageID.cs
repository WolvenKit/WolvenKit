using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownStorageID : CVariable
	{
		private CUInt32 _iD;
		private CEnum<EBOOL> _isValid;

		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(1)] 
		[RED("isValid")] 
		public CEnum<EBOOL> IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}

		public CooldownStorageID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
