using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility
{
    public static class SD
    {
        public const string Role_Customer = "Müşteri";
        public const string Role_Company = "YayınEvi";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Çalışan";

		public const string StatusPending = "Beklemede";
		public const string StatusApproved = "Onaylandı";
		public const string StatusInProcess = "İşelemde";
		public const string StatusShipped = "Gönderildi";
		public const string StatusCancelled = "İptal Edildi";
		public const string StatusRefunded = "Geri ödeme yapıldı";

		public const string PaymentStatusPending = "Beklemede";
		public const string PaymentStatusApproved = "Onaylandı";
		public const string PaymentStatusDelayedPayment = "Geciken Ödeme İçin Onaylandı";
		public const string PaymentStatusRejected = "Reddedildi";


		public const string SessionCart = "SessionShoppingCart";
	}
}
