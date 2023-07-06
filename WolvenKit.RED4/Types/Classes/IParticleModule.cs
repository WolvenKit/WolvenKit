using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class IParticleModule : ISerializable
	{
		[Ordinal(0)] 
		[RED("editorName")] 
		public CString EditorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("editorGroup")] 
		public CString EditorGroup
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IParticleModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
