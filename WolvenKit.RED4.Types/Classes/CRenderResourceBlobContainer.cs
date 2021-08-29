using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderResourceBlobContainer : ISerializable
	{
		private CHandle<IRenderResourceBlob> _blob;

		[Ordinal(0)] 
		[RED("blob")] 
		public CHandle<IRenderResourceBlob> Blob
		{
			get => GetProperty(ref _blob);
			set => SetProperty(ref _blob, value);
		}
	}
}
