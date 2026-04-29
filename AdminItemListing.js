let selectedCard = null;

document.querySelectorAll('.product-card').forEach(card => {
    card.addEventListener('click', () => {
        document.querySelectorAll('.product-card').forEach(c => c.classList.remove('selected'));
        selectedCard = card;
        card.classList.add('selected');
    });
});

function filterProducts() {
    const q = document.getElementById('productSearch').value.toLowerCase();
    document.querySelectorAll('.product-card').forEach(c => {
        c.style.display = c.dataset.name.includes(q) ? '' : 'none';
    });
}

function showToast(msg, type) {
    const t = document.getElementById('toast');
    t.textContent = msg;
    t.className = 'toast show ' + (type || '');
    setTimeout(() => { t.className = 'toast'; }, 2500);
}

function approveItem() {
    if (!selectedCard) {
        showToast('Please select an item first.', '');
        return;
    }
    showToast(`"${selectedCard.dataset.name}" approved!`, 'green');
    selectedCard.classList.remove('selected');
    selectedCard = null;
}

function removeItem() {
    if (!selectedCard) {
        showToast('Please select an item first.', '');
        return;
    }
    showToast(`"${selectedCard.dataset.name}" removed.`, 'red');
    selectedCard.classList.remove('selected');
    selectedCard = null;
}

function openModal() {
    document.getElementById('deleteModal').classList.add('active');
}

function closeModal() {
    document.getElementById('deleteModal').classList.remove('active');
}

function confirmDelete() {
    closeModal();
    showToast('Account deleted.', 'red');
}

document.getElementById('deleteModal').addEventListener('click', function (e) {
    if (e.target === this) closeModal();
});