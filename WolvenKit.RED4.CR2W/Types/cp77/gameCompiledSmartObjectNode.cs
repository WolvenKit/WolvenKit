using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledSmartObjectNode : CVariable
	{
		private CHandle<gameCompiledSmartObjectData> _compiledData;
		private WorldTransform _worldTransform;

		[Ordinal(0)] 
		[RED("compiledData")] 
		public CHandle<gameCompiledSmartObjectData> CompiledData
		{
			get => GetProperty(ref _compiledData);
			set => SetProperty(ref _compiledData, value);
		}

		[Ordinal(1)] 
		[RED("worldTransform")] 
		public WorldTransform WorldTransform
		{
			get => GetProperty(ref _worldTransform);
			set => SetProperty(ref _worldTransform, value);
		}

		public gameCompiledSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
