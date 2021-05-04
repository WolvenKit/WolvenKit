using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownItemData : IScriptable
	{
		private CVariant _identifier;
		private CName _labelKey;
		private CEnum<DropdownItemDirection> _direction;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("labelKey")] 
		public CName LabelKey
		{
			get => GetProperty(ref _labelKey);
			set => SetProperty(ref _labelKey, value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<DropdownItemDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public DropdownItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
