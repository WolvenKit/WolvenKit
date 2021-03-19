using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNarrativePlateData : CVariable
	{
		private CString _text;
		private CString _caption;
		private wCHandle<gameObject> _entity;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetProperty(ref _caption);
			set => SetProperty(ref _caption, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<gameObject> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		public gameuiNarrativePlateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
