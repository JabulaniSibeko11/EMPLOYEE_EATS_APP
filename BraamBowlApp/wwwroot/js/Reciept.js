
        // Clear cart after order
    if (@((TempData["ClearCart"] != null).ToString().ToLower())) {
        sessionStorage.removeItem('cart');
        }

    function closeModal() {
            const modal = document.querySelector('.receipt-modal');
    modal.style.animation = 'slideDown 0.4s ease forwards';

            setTimeout(() => {
        window.location.href = '@Url.Action("Index", "Home", new { id = Model.ShopId })';
            }, 400);
        }

    // Close on Escape key
    document.addEventListener('keydown', function(e) {
            if (e.key === 'Escape') {
        closeModal();
            }
        });

    // Prevent body scroll
    document.body.style.overflow = 'hidden';

    // Add slide down animation
    const style = document.createElement('style');
    style.textContent = `
    @keyframes slideDown {
        to {
        opacity: 0;
    transform: translateY(60px) scale(0.9);
                }
            }
    `;
    document.head.appendChild(style);
