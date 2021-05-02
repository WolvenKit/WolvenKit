using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutResource : CResource
	{
		private CHandle<worldBlockoutData> _blockoutData;

		[Ordinal(1)] 
		[RED("blockoutData")] 
		public CHandle<worldBlockoutData> BlockoutData
		{
			get => GetProperty(ref _blockoutData);
			set => SetProperty(ref _blockoutData, value);
		}

		public worldBlockoutResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
