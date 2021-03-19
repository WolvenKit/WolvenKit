using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsMultipleSetEnableEvent : redEvent
	{
		private CStatic<CBool> _enable;
		private CStatic<CName> _layer;
		private CStatic<CName> _linkedLayers;

		[Ordinal(0)] 
		[RED("enable", 4)] 
		public CStatic<CBool> Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("layer", 4)] 
		public CStatic<CName> Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}

		[Ordinal(2)] 
		[RED("linkedLayers", 4)] 
		public CStatic<CName> LinkedLayers
		{
			get => GetProperty(ref _linkedLayers);
			set => SetProperty(ref _linkedLayers, value);
		}

		public gameinteractionsMultipleSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
