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
			get
			{
				if (_blob == null)
				{
					_blob = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "blob", cr2w, this);
				}
				return _blob;
			}
			set
			{
				if (_blob == value)
				{
					return;
				}
				_blob = value;
				PropertySet(this);
			}
		}

		public CRenderResourceBlobContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
