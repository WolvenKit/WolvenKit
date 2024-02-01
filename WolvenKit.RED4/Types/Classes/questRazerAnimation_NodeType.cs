using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRazerAnimation_NodeType : questIFXManagerNodeType
	{
		[Ordinal(0)] 
		[RED("playParams")] 
		public CArray<questPlayRazerAnimation_NodeTypeParams> PlayParams
		{
			get => GetPropertyValue<CArray<questPlayRazerAnimation_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questPlayRazerAnimation_NodeTypeParams>>(value);
		}

		[Ordinal(1)] 
		[RED("stopParams")] 
		public CArray<questStopRazerAnimation_NodeTypeParams> StopParams
		{
			get => GetPropertyValue<CArray<questStopRazerAnimation_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questStopRazerAnimation_NodeTypeParams>>(value);
		}

		[Ordinal(2)] 
		[RED("idleParams")] 
		public CArray<questSetIdleRazerAnimation_NodeTypeParams> IdleParams
		{
			get => GetPropertyValue<CArray<questSetIdleRazerAnimation_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questSetIdleRazerAnimation_NodeTypeParams>>(value);
		}

		public questRazerAnimation_NodeType()
		{
			PlayParams = new() { new questPlayRazerAnimation_NodeTypeParams() };
			StopParams = new() { new questStopRazerAnimation_NodeTypeParams() };
			IdleParams = new() { new questSetIdleRazerAnimation_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
