using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CRenderResourceBlobContainer : ISerializable
	{
		private CHandle<IRenderResourceBlob> _blob;

		[Ordinal(0)] 
		[RED("blob")] 
		public CHandle<IRenderResourceBlob> Blob
		{
			get => GetProperty(ref _blob);
			set => SetProperty(ref _blob, value);
		}

		public CRenderResourceBlobContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
