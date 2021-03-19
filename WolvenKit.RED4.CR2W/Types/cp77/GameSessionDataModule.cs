using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataModule : IScriptable
	{
		private CEnum<EGameSessionDataType> _moduleType;

		[Ordinal(0)] 
		[RED("moduleType")] 
		public CEnum<EGameSessionDataType> ModuleType
		{
			get => GetProperty(ref _moduleType);
			set => SetProperty(ref _moduleType, value);
		}

		public GameSessionDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
