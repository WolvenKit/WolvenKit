using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderResourceBlobContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("blob")] 
		public CHandle<IRenderResourceBlob> Blob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}
	}
}
