﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ayobeli_asp {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class StringResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ayobeli_asp.StringResource", typeof(StringResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selamat anda telah menjadi anggota AyoBeli! &lt;hr class=&quot;my-4&quot;&gt;&lt;/br&gt; &lt;a class=&quot;btn btn-primary btn-lg&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;Beranda&lt;/a&gt;.
        /// </summary>
        public static string ConfirmedEmailExplanation {
            get {
                return ResourceManager.GetString("ConfirmedEmailExplanation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alamat email anda telah dikonfirmasi.
        /// </summary>
        public static string ConfirmedEmailTopMessage {
            get {
                return ResourceManager.GetString("ConfirmedEmailTopMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ilovefap2@gmail.com.
        /// </summary>
        public static string EmailAccount {
            get {
                return ResourceManager.GetString("EmailAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to maxpower22.
        /// </summary>
        public static string EmailPassword {
            get {
                return ResourceManager.GetString("EmailPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Terdapat kesalahan pada server.
        /// </summary>
        public static string ErrorBadGateway {
            get {
                return ResourceManager.GetString("ErrorBadGateway", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Halaman yang anda cari tidak ada.
        /// </summary>
        public static string ErrorPageNotFound {
            get {
                return ResourceManager.GetString("ErrorPageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Konfirmasi alamat email anda untuk dapat segera bertransaksi. Bila anda tidak menerima email permintaan konfirmasi, silahkan klik tombol dibawah. &lt;hr class=&quot;my-4&quot;&gt;&lt;/br&gt; &lt;a class=&quot;btn btn-primary btn-lg&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;Kirim email&lt;/a&gt; .
        /// </summary>
        public static string RegisterSuccessExplanation {
            get {
                return ResourceManager.GetString("RegisterSuccessExplanation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alamat email anda telah berhasil didaftarkan.
        /// </summary>
        public static string RegisterSuccessTopMessage {
            get {
                return ResourceManager.GetString("RegisterSuccessTopMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;br/&gt;&lt;br/&gt;Kami senang untuk memberitahukan bahwa akun AyoBeli anda telah sukses dibuat. Tolong klik tombol dibawah ini untuk memverifikasi akun anda.&lt;br/&gt;&lt;br/&gt;&lt;a href=&quot;{0}&quot; class=&quot;btn btn-primary btn-lg&quot; role=&quot;button&quot; aria-pressed=&quot;true&quot;&gt;Verifikasi&lt;/a&gt;.
        /// </summary>
        public static string VerifyEmailBody {
            get {
                return ResourceManager.GetString("VerifyEmailBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Akun anda telah sukses dibuat.
        /// </summary>
        public static string VerifyEmailSubject {
            get {
                return ResourceManager.GetString("VerifyEmailSubject", resourceCulture);
            }
        }
    }
}
